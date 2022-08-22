using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Graphics;

namespace BeautyShopApp.Controls
{
    /// <summary>
    /// Provides a grid-style layout panel where each tile/cell can be variable size based on content.
    /// </summary>
    public class VariableSizedWrapGrid : Layout<View>
    {
        bool _ignorePropertyChange;

        readonly Dictionary<View, Rect> _arrangeInfo = new Dictionary<View, Rect>();

        public double ItemWidth
        {
            get { return (double)GetValue(ItemWidthProperty); }
            set { SetValue(ItemWidthProperty, value); }
        }

        public static readonly BindableProperty ItemWidthProperty =
            BindableProperty.Create(nameof(ItemWidth), typeof(double), typeof(VariableSizedWrapGrid), double.NaN,
                BindingMode.TwoWay, propertyChanged: (bindable, oldvalue, newvalue) => ((VariableSizedWrapGrid)bindable).OnItemWidthOrHeightChanged(bindable, oldvalue, newvalue));

        public double ItemHeight
        {
            get { return (double)GetValue(ItemHeightProperty); }
            set { SetValue(ItemHeightProperty, value); }
        }
 
        public static readonly BindableProperty ItemHeightProperty =
            BindableProperty.Create(nameof(ItemHeight), typeof(double), typeof(VariableSizedWrapGrid), double.NaN,
                BindingMode.TwoWay, propertyChanged: (bindable, oldvalue, newvalue) => ((VariableSizedWrapGrid)bindable).OnItemWidthOrHeightChanged(bindable, oldvalue, newvalue));

        public int MaximumRowsOrColumns
        {
            get { return (int)GetValue(MaximumRowsOrColumnsProperty); }
            set { SetValue(MaximumRowsOrColumnsProperty, value); }
        }
   
        public static readonly BindableProperty MaximumRowsOrColumnsProperty =
            BindableProperty.Create(nameof(MaximumRowsOrColumns), typeof(int), typeof(VariableSizedWrapGrid), -1,
                BindingMode.TwoWay, propertyChanged: (bindable, oldvalue, newvalue) => ((VariableSizedWrapGrid)bindable).OnMaximumRowsOrColumnsChanged());

        void OnMaximumRowsOrColumnsChanged()
        {
            InvalidateMeasure();
        }

        public StackOrientation Orientation
        {
            get { return (StackOrientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly BindableProperty OrientationProperty =
            BindableProperty.Create(nameof(Orientation), typeof(StackOrientation), typeof(VariableSizedWrapGrid), StackOrientation.Horizontal,   
                BindingMode.TwoWay, propertyChanged: (bindable, oldvalue, newvalue) => ((VariableSizedWrapGrid)bindable).OnOrientationChanged(bindable, oldvalue, newvalue));

        void OnOrientationChanged(BindableObject bindable, object oldValue, object newValue)
        {
            StackOrientation value = (StackOrientation)newValue;

            // Ignore the change if requested
            if (_ignorePropertyChange)
            {
                _ignorePropertyChange = false;
                return;
            }

            // Validate the Orientation
            if ((value != StackOrientation.Horizontal) &&
                (value != StackOrientation.Vertical))
            {
                // Reset the property to its original state before throwing
                _ignorePropertyChange = true;
                SetValue(OrientationProperty, (StackOrientation)oldValue);

                throw new ArgumentException();
            }

            // Orientation affects measuring.
            InvalidateMeasure();
        }

        public static int GetRowSpan(View element)
        {
            return (int)element.GetValue(RowSpanProperty);
        }

        public static void SetRowSpan(View element, int value)
        {
            element.SetValue(RowSpanProperty, value);
        }

        public static readonly BindableProperty RowSpanProperty =   
            BindableProperty.Create("RowSpan", typeof(int), typeof(VariableSizedWrapGrid), 1);

        public static int GetColumnSpan(View element)
        {
            return (int)element.GetValue(ColumnSpanProperty);
        }

        public static void SetColumnSpan(View element, int value)
        {
            element.SetValue(ColumnSpanProperty, value);
        }

        public static readonly BindableProperty ColumnSpanProperty =
            BindableProperty.Create("ColumnSpan", typeof(int), typeof(VariableSizedWrapGrid), 1);

        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            double itemWidth = ItemWidth;
            double itemHeight = ItemHeight;

            int maximumRowsOrColumns = MaximumRowsOrColumns;
            StackOrientation orientation = Orientation;

            if (double.IsNaN(itemWidth) || double.IsNaN(itemHeight))
            {
                throw new InvalidOperationException();
            }

            int rows = double.IsPositiveInfinity(heightConstraint) ? int.MaxValue : (int)(heightConstraint / itemHeight);
            int columns = double.IsPositiveInfinity(widthConstraint) ? int.MaxValue : (int)(widthConstraint / itemWidth);

            if (maximumRowsOrColumns > 0)
            {
                if (orientation == StackOrientation.Horizontal)
                {
                    if (columns > maximumRowsOrColumns)
                    {
                        columns = maximumRowsOrColumns;
                    }
                }
                else
                {
                    if (rows > maximumRowsOrColumns)
                    {
                        rows = maximumRowsOrColumns;
                    }
                }
            }

            ICollection<Point> filledCells = new List<Point>();
            bool noCellsAvailable = false;

            int x = 0;
            int y = 0;

            double desiredWidth = 0;
            double desiredHeight = 0;

            _arrangeInfo.Clear();

            foreach (View child in Children)
            {
                int rowSpan = Math.Max(GetRowSpan(child), 1);
                int columnSpan = Math.Max(GetColumnSpan(child), 1);

                child.Measure(itemWidth * columnSpan, itemHeight * rowSpan);

                if (noCellsAvailable)
                {
                    continue;
                }

                if (rowSpan > rows)
                {
                    rowSpan = rows;
                }

                if (columnSpan > columns)
                {
                    columnSpan = columns;
                }

                if (!TryComputeCellPosition(rows, columns, rowSpan, columnSpan, filledCells, ref x, ref y))
                {
                    noCellsAvailable = true;
                    continue;
                }

                if (y + rowSpan > rows)
                {
                    rowSpan = rows - y;
                }

                if (x + columnSpan > columns)
                {
                    columnSpan = columns - x;
                }

                Rect childRect = new Rect(x * itemWidth, y * itemHeight, itemWidth * columnSpan, itemHeight * rowSpan);
                _arrangeInfo[child] = childRect;

                if (desiredWidth < childRect.Right)
                {
                    desiredWidth = childRect.Right;
                }

                if (desiredHeight < childRect.Bottom)
                {
                    desiredHeight = childRect.Bottom;
                }

                for (int row = y; row < y + rowSpan; row++)
                {
                    for (int column = x; column < x + columnSpan; column++)
                    {
                        filledCells.Add(new Point(column, row));
                    }
                }

                if (orientation == StackOrientation.Horizontal)
                {
                    x += columnSpan;
                }
                else
                {
                    y += rowSpan;
                }
            }

            return new SizeRequest(new Size(desiredWidth, desiredHeight));
        }

        protected override void LayoutChildren(double x, double y, double width, double height)
        {
            foreach (KeyValuePair<View, Rect> info in _arrangeInfo)
            {
                LayoutChildIntoBoundingRegion(info.Key, info.Value);
            }

            _arrangeInfo.Clear();
        }

        void OnItemWidthOrHeightChanged(BindableObject bindable, object oldValue, object newValue)
        {
            double value = (double)newValue;

            // Ignore the change if requested
            if (_ignorePropertyChange)
            {
                _ignorePropertyChange = false;
                return;
            }

            // Validate the length (which must be a positive,
            // finite number)
            if ((value <= 0.0) || double.IsPositiveInfinity(value))
            {
                // Reset the property to its original state before throwing
                _ignorePropertyChange = true;
                SetValue(ItemWidthProperty, (double)oldValue);

                throw new ArgumentException();
            }

            // The length properties affect measuring.
            InvalidateMeasure();
        }

        bool TryComputeCellPosition(int rows, int columns, int rowSpan, int columnSpan, ICollection<Point> filledCells, ref int x, ref int y)
        {
            StackOrientation orientation = Orientation;

            int direct;
            int indirect;
            int directSpan;
            int indirectSpan;
            int maxDirect;
            int maxIndirect;

            if (orientation == StackOrientation.Horizontal)
            {
                direct = x;
                indirect = y;
                directSpan = columnSpan;
                indirectSpan = rowSpan;
                maxDirect = columns;
                maxIndirect = rows;
            }
            else
            {
                direct = y;
                indirect = x;
                directSpan = rowSpan;
                indirectSpan = columnSpan;
                maxDirect = rows;
                maxIndirect = columns;
            }

            for (; indirect + indirectSpan <= maxIndirect; indirect++)
            {
                for (; direct + directSpan <= maxDirect; direct++)
                {
                    Point cellPosition = orientation == StackOrientation.Horizontal ? new Point(direct, indirect) : new Point(indirect, direct);
                    if (!filledCells.Contains(cellPosition))
                    {
                        x = (int)cellPosition.X;
                        y = (int)cellPosition.Y;
                        return true;
                    }
                }

                direct = 0;
            }

            for (; indirect < maxIndirect; indirect++)
            {
                for (; direct < maxDirect; direct++)
                {
                    Point cellPosition = orientation == StackOrientation.Horizontal ? new Point(direct, indirect) : new Point(indirect, direct);
                    if (!filledCells.Contains(cellPosition))
                    {
                        x = (int)cellPosition.X;
                        y = (int)cellPosition.Y;
                        return true;
                    }
                }

                direct = 0;
            }

            return false;
        }
    }
}