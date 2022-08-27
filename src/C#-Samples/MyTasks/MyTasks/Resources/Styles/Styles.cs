namespace MyTasks
{
    public partial class Styles : ResourceDictionary
    {
        public Styles()
        {
            Add("FontSize10", 10d);
            Add("FontSize12", 12d);
            Add("FontSize13", 13d);
            Add("FontSize14", 14d);
            Add("FontSize16", 16d);
            Add("FontSize18", 18d);
            Add("FontSize20", 20d);
            Add("FontSize24", 24d);
            Add("FontSize26", 26d);
            Add("FontSize28", 28d);
            Add("FontSize36", 36d);
            Add(new Style(typeof(ActivityIndicator))
            {
                Setters =
                {
                    new() { Property = ActivityIndicator.ColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Primary") } },
                },
            });
            Add(new Style(typeof(IndicatorView))
            {
                Setters =
                {
                    new() { Property = IndicatorView.IndicatorColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray500"), AppTheme.Light or _ => AppResource<Color>("Gray200") } },
                    new() { Property = IndicatorView.SelectedIndicatorColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray100"), AppTheme.Light or _ => AppResource<Color>("Gray950") } },
                },
            });
            Add(new Style(typeof(Border))
            {
                Setters =
                {
                    new() { Property = Border.StrokeProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray500"), AppTheme.Light or _ => AppResource<Color>("Gray200") } },
                    new() { Property = Border.StrokeShapeProperty, Value = "Rectangle" },
                    new() { Property = Border.StrokeThicknessProperty, Value = 1 },
                },
            });
            Add(new Style(typeof(BoxView))
            {
                Setters =
                {
                    new() { Property = BoxView.ColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray200"), AppTheme.Light or _ => AppResource<Color>("Gray950") } },
                },
            });
            Add(new Style(typeof(Button))
            {
                Setters =
                {
                    new() { Property = Button.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Primary"), AppTheme.Light or _ => AppResource<Color>("White") } },
                    new() { Property = Button.BackgroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Primary") } },
                    new() { Property = Button.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = Button.FontSizeProperty, Value = 14 },
                    new() { Property = Button.CornerRadiusProperty, Value = 8 },
                    new() { Property = Button.PaddingProperty, Value = new Thickness(14,10) },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = Button.TextColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray200"), AppTheme.Light or _ => AppResource<Color>("Gray950") },
                                            },
                                            new Setter()
                                            {
                                                Property = Button.BackgroundColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray200") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(CheckBox))
            {
                Setters =
                {
                    new() { Property = CheckBox.ColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Primary") } },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = CheckBox.ColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(DatePicker))
            {
                Setters =
                {
                    new() { Property = DatePicker.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Gray900") } },
                    new() { Property = DatePicker.BackgroundColorProperty, Value = Transparent },
                    new() { Property = DatePicker.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = DatePicker.FontSizeProperty, Value = 14 },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = DatePicker.TextColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray500"), AppTheme.Light or _ => AppResource<Color>("Gray200") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(Editor))
            {
                Setters =
                {
                    new() { Property = Editor.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Black") } },
                    new() { Property = Editor.BackgroundColorProperty, Value = Transparent },
                    new() { Property = Editor.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = Editor.FontSizeProperty, Value = 14 },
                    new() { Property = Editor.PlaceholderColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray500"), AppTheme.Light or _ => AppResource<Color>("Gray200") } },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = Editor.TextColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(Entry))
            {
                Setters =
                {
                    new() { Property = Entry.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Black") } },
                    new() { Property = Entry.BackgroundColorProperty, Value = Transparent },
                    new() { Property = Entry.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = Entry.FontSizeProperty, Value = 14 },
                    new() { Property = Entry.PlaceholderColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray500"), AppTheme.Light or _ => AppResource<Color>("Gray200") } },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = Entry.TextColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(Frame))
            {
                Setters =
                {
                    new() { Property = MauiFrame.HasShadowProperty, Value = false },
                    new() { Property = MauiFrame.BorderColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray950"), AppTheme.Light or _ => AppResource<Color>("Gray200") } },
                    new() { Property = MauiFrame.CornerRadiusProperty, Value = 8 },
                },
            });
            Add(new Style(typeof(ImageButton))
            {
                Setters =
                {
                    new() { Property = ImageButton.OpacityProperty, Value = 1 },
                    new() { Property = ImageButton.BorderColorProperty, Value = Transparent },
                    new() { Property = ImageButton.BorderWidthProperty, Value = 0 },
                    new() { Property = ImageButton.CornerRadiusProperty, Value = 0 },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = ImageButton.OpacityProperty,
                                                Value = 0.5,
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Gray900") } },
                    new() { Property = Label.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = Label.FontSizeProperty, Value = 14 },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = Label.TextColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(ListView))
            {
                Setters =
                {
                    new() { Property = ListView.SeparatorColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray500"), AppTheme.Light or _ => AppResource<Color>("Gray200") } },
                    new() { Property = ListView.RefreshControlColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray200"), AppTheme.Light or _ => AppResource<Color>("Gray900") } },
                },
            });
            Add(new Style(typeof(Picker))
            {
                Setters =
                {
                    new() { Property = Picker.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Gray900") } },
                    new() { Property = Picker.TitleColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray200"), AppTheme.Light or _ => AppResource<Color>("Gray900") } },
                    new() { Property = Picker.BackgroundColorProperty, Value = Transparent },
                    new() { Property = Picker.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = Picker.FontSizeProperty, Value = 14 },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = Picker.TextColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                            new Setter()
                                            {
                                                Property = Picker.TitleColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(ProgressBar))
            {
                Setters =
                {
                    new() { Property = ProgressBar.ProgressColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Primary") } },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = ProgressBar.ProgressColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(RadioButton))
            {
                Setters =
                {
                    new() { Property = RadioButton.BackgroundProperty, Value = "Transparent" },
                    new() { Property = RadioButton.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Black") } },
                    new() { Property = RadioButton.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = RadioButton.FontSizeProperty, Value = 14 },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = RadioButton.TextColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(RefreshView))
            {
                Setters =
                {
                    new() { Property = RefreshView.RefreshColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray200"), AppTheme.Light or _ => AppResource<Color>("Gray900") } },
                },
            });
            Add(new Style(typeof(SearchBar))
            {
                Setters =
                {
                    new() { Property = SearchBar.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Gray900") } },
                    new() { Property = SearchBar.PlaceholderColorProperty, Value = AppResource<Color>("Gray500") },
                    new() { Property = SearchBar.CancelButtonColorProperty, Value = AppResource<Color>("Gray500") },
                    new() { Property = SearchBar.BackgroundColorProperty, Value = Transparent },
                    new() { Property = SearchBar.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = SearchBar.FontSizeProperty, Value = 14 },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = SearchBar.TextColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                            new Setter()
                                            {
                                                Property = SearchBar.PlaceholderColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(SearchHandler))
            {
                Setters =
                {
                    new() { Property = SearchHandler.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Gray900") } },
                    new() { Property = SearchHandler.PlaceholderColorProperty, Value = AppResource<Color>("Gray500") },
                    new() { Property = SearchHandler.BackgroundColorProperty, Value = Transparent },
                    new() { Property = SearchHandler.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = SearchHandler.FontSizeProperty, Value = 14 },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = SearchHandler.TextColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                            new Setter()
                                            {
                                                Property = SearchHandler.PlaceholderColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(Shadow))
            {
                Setters =
                {
                    new() { Property = Shadow.RadiusProperty, Value = 15 },
                    new() { Property = Shadow.OpacityProperty, Value = 0.5 },
                    new() { Property = Shadow.BrushProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("White") } },
                    new() { Property = Shadow.OffsetProperty, Value = new Point(10,10) },
                },
            });
            Add(new Style(typeof(Slider))
            {
                Setters =
                {
                    new() { Property = Slider.MinimumTrackColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Primary") } },
                    new() { Property = Slider.MaximumTrackColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray200") } },
                    new() { Property = Slider.ThumbColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Primary") } },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = Slider.MinimumTrackColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                            new Setter()
                                            {
                                                Property = Slider.MaximumTrackColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                            new Setter()
                                            {
                                                Property = Slider.ThumbColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(SwipeItem))
            {
                Setters =
                {
                    new() { Property = SwipeItem.BackgroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Black"), AppTheme.Light or _ => AppResource<Color>("White") } },
                },
            });
            Add(new Style(typeof(Switch))
            {
                Setters =
                {
                    new() { Property = Switch.OnColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Primary") } },
                    new() { Property = Switch.ThumbColorProperty, Value = AppResource<Color>("White") },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = Switch.OnColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                            new Setter()
                                            {
                                                Property = Switch.ThumbColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                        },
                                    },
                                    new VisualState()
                                    {
                                        Name = "On",
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = Switch.OnColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray200"), AppTheme.Light or _ => AppResource<Color>("Secondary") },
                                            },
                                            new Setter()
                                            {
                                                Property = Switch.ThumbColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Primary") },
                                            },
                                        },
                                    },
                                    new VisualState()
                                    {
                                        Name = "Off",
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = Switch.ThumbColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray500"), AppTheme.Light or _ => AppResource<Color>("Gray400") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(TimePicker))
            {
                Setters =
                {
                    new() { Property = TimePicker.TextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Gray900") } },
                    new() { Property = TimePicker.BackgroundProperty, Value = "Transparent" },
                    new() { Property = TimePicker.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = TimePicker.FontSizeProperty, Value = 14 },
                    new Setter()
                    {
                        Property = VisualStateManager.VisualStateGroupsProperty,
                        Value = CreateVisualStateGroupList(new[]
                        {
                            new VisualStateGroup()
                            {
                                Name = nameof(VisualStateManager.CommonStates),
                                States =
                                {
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Normal,
                                    },
                                    new VisualState()
                                    {
                                        Name = VisualStateManager.CommonStates.Disabled,
                                        Setters =
                                        {
                                            new Setter()
                                            {
                                                Property = TimePicker.TextColorProperty,
                                                Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray600"), AppTheme.Light or _ => AppResource<Color>("Gray300") },
                                            },
                                        },
                                    },
                                },
                            },
                        })
                    },
                },
            });
            Add(new Style(typeof(Page))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new() { Property = Page.PaddingProperty, Value = Thickness.Zero },
                    new() { Property = Page.BackgroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Black"), AppTheme.Light or _ => AppResource<Color>("White") } },
                },
            });
            Add(new Style(typeof(Shell))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new() { Property = Shell.BackgroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray950"), AppTheme.Light or _ => AppResource<Color>("Primary") } },
                    new() { Property = Shell.ForegroundColorProperty, Value = DeviceInfo.Platform.ToString() switch { nameof(DevicePlatform.WinUI) => AppResource<Color>("Primary"), _ => AppResource<Color>("White") } },
                    new() { Property = Shell.TitleColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("White") } },
                    new() { Property = Shell.DisabledColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray950"), AppTheme.Light or _ => AppResource<Color>("Gray200") } },
                    new() { Property = Shell.UnselectedColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray200"), AppTheme.Light or _ => AppResource<Color>("Gray200") } },
                    new() { Property = Shell.NavBarHasShadowProperty, Value = false },
                    new() { Property = Shell.TabBarBackgroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Black"), AppTheme.Light or _ => AppResource<Color>("White") } },
                    new() { Property = Shell.TabBarForegroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Primary") } },
                    new() { Property = Shell.TabBarTitleColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Primary") } },
                    new() { Property = Shell.TabBarUnselectedColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray200"), AppTheme.Light or _ => AppResource<Color>("Gray900") } },
                },
            });
            Add(new Style(typeof(NavigationPage))
            {
                Setters =
                {
                    new() { Property = NavigationPage.BarBackgroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray950"), AppTheme.Light or _ => AppResource<Color>("Primary") } },
                    new() { Property = NavigationPage.BarTextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Gray200") } },
                    new() { Property = NavigationPage.IconColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Gray200") } },
                },
            });
            Add(new Style(typeof(TabbedPage))
            {
                Setters =
                {
                    new() { Property = TabbedPage.BarBackgroundColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray950"), AppTheme.Light or _ => AppResource<Color>("White") } },
                    new() { Property = TabbedPage.BarTextColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("White"), AppTheme.Light or _ => AppResource<Color>("Primary") } },
                    new() { Property = TabbedPage.UnselectedTabColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray950"), AppTheme.Light or _ => AppResource<Color>("Gray200") } },
                    new() { Property = TabbedPage.SelectedTabColorProperty, Value = Application.Current.RequestedTheme switch { AppTheme.Dark => AppResource<Color>("Gray200"), AppTheme.Light or _ => AppResource<Color>("Gray950") } },
                },
            });
        }
    }
}

