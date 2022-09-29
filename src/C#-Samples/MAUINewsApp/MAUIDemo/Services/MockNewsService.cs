namespace MAUIDemo.Services
{
    public class MockNewsService : INewsService
    {
        public ICollection<string> GetTags()
        {
            return new List<string>()
            {
                "#today",
                "#health",
                "#politics",
                "#nature",
                "#music",
                "#arts",
                "#marketing",
                "#business",
                "#science",
                "#world",
                "#sports",
                "#party"
            };
        }

        public ICollection<Category> GetCategories()
        {
            var categories = new List<Category>()
            {
                new Category("Health", MaterialDesignIcons.Spa),
                new Category("Politics", MaterialDesignIcons.AccountBalance),
                new Category("Business", MaterialDesignIcons.Work),
                new Category("Music", MaterialDesignIcons.MusicNote),
                new Category("Marketing", MaterialDesignIcons.Store),
                new Category("Nature", MaterialDesignIcons.LocalFlorist),
                new Category("Arts", MaterialDesignIcons.ColorLens),
                new Category("Travel", MaterialDesignIcons.FlightTakeoff),
                new Category("Food", MaterialDesignIcons.Restaurant),
                new Category("Style", MaterialDesignIcons.Style),
            };

            for (int i = 0; i < categories.Count; i++)
            {
                // Two column layout, hence a row repeats after every two items
                categories[i].RowIndex = i / 2;
                // Two column layout, hence a column index repeats after every item
                categories[i].ColIndex = i % 2 == 0 ? 0 : 1;
            }

            return categories;
        }

        public ICollection<Article> GetLatestArticles()
        {
            return new List<Article>()
            {
                new Article("001",
                    "Massa ultricies mi quis hendrerit dolor magna eget.",
                    "Ut venenatis tellus in metus vulputate eu. Enim neque volutpat ac tincidunt vitae semper quis.",
                    "https://picsum.photos/seed/one/300/200",
                    "Business", "8m ago"),
                new Article("002",
                    "Auctor elit sed vulputate mi sit amet mauris.",
                    "Habitasse platea dictumst vestibulum rhoncus est. Et ligula ullamcorper malesuada proin libero nunc.",
                    "https://picsum.photos/seed/three/300/200",
                    "Sports", "12m ago"),
                new Article("003",
                    "Nibh venenatis cras sed felis eget velit aliquet.",
                    "Sollicitudin ac orci phasellus egestas. Nulla facilisi cras fermentum odio eu feugiat pretium nibh.",
                    "https://picsum.photos/seed/two/300/200",
                    "Science", "16m ago"),
                new Article("004",
                    "Massa tempor nec feugiat nisl pretium fusce.",
                    "Tellus in metus vulputate eu scelerisque felis imperdiet. Orci eu lobortis elementum nibh tellus molestie nunc non blandit.",
                    "https://picsum.photos/seed/four/300/200",
                    "Politics", "23m ago")
            };
        }

        public ICollection<Article> GetPopularArticles()
        {
            return new List<Article>()
            {
                new Article("005",
                    "Nullam vehicula ipsum a arcu cursus vitae congue mauris rhoncus.",
                    "Tempus quam pellentesque nec nam aliquam sem. Sed faucibus turpis in eu mi bibendum neque.",
                    "https://picsum.photos/seed/nine/300/200",
                    "Business", "9m ago"),
                new Article("006",
                    "Cursus metus aliquam eleifend mi in nulla posuere.",
                    "Volutpat lacus laoreet non curabitur gravida arcu. Quis imperdiet massa tincidunt nunc pulvinar sapien et.",
                    "https://picsum.photos/seed/ten/300/200",
                    "Sports", "12m ago"),
                new Article("007",
                    "Consequat interdum varius sit amet mattis vulputate enim nulla.",
                    "Elementum integer enim neque volutpat. Sit amet consectetur adipiscing elit pellentesque habitant morbi tristique senectus.",
                    "https://picsum.photos/seed/eleven/300/200",
                    "Science", "16m ago"),
                new Article("008",
                    "Augue ut lectus arcu bibendum at varius vel pharetra vel.",
                    "Tempus quam pellentesque nec nam aliquam sem. Sed faucibus turpis in eu mi bibendum neque.",
                    "https://picsum.photos/seed/twelve/300/200",
                    "Politics", "23m ago")
            };
        }

        public ICollection<Article> GetRecommendedArticles()
        {
            return new List<Article>()
            {
                new Article("009",
                    "Dictum fusce ut placerat orci nulla pellentesque.",
                    "Volutpat lacus laoreet non curabitur gravida arcu. Quis imperdiet massa tincidunt nunc pulvinar sapien et.",
                    "https://picsum.photos/seed/five/300/200",
                    "Business", "10m ago"),
                new Article("010",
                    "Facilisi cras fermentum odio eu feugiat pretium nibh ipsum consequat.",
                    "Elementum integer enim neque volutpat. Sit amet consectetur adipiscing elit pellentesque habitant morbi tristique senectus.",
                    "https://picsum.photos/seed/six/300/200",
                    "Sports", "12m ago"),
                new Article("011",
                    "Volutpat odio facilisis mauris sit amet massa vitae.",
                    "Tempus quam pellentesque nec nam aliquam sem. Sed faucibus turpis in eu mi bibendum neque.",
                    "https://picsum.photos/seed/seven/300/200",
                    "Science", "16m ago"),
                new Article("012",
                    "Blandit volutpat maecenas volutpat blandit aliquam etiam.",
                    "Tempus quam pellentesque nec nam aliquam sem. Sed faucibus turpis in eu mi bibendum neque.",
                    "https://picsum.photos/seed/eight/300/200",
                    "Politics", "23m ago")
            };
        }

        public string GetArticleBody(string articleId)
        {
            return "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Tortor dignissim convallis aenean et tortor at risus viverra adipiscing. Maecenas pharetra convallis posuere morbi leo urna molestie. Tellus molestie nunc non blandit massa. Tempor orci eu lobortis elementum nibh. Posuere sollicitudin aliquam ultrices sagittis orci. Mi ipsum faucibus vitae aliquet nec ullamcorper sit amet risus. Lorem dolor sed viverra ipsum nunc aliquet bibendum. Ut porttitor leo a diam sollicitudin tempor. Eu facilisis sed odio morbi. Semper feugiat nibh sed pulvinar proin gravida. Ullamcorper sit amet risus nullam eget felis. Turpis massa sed elementum tempus egestas sed sed risus. Non nisi est sit amet facilisis magna etiam tempor orci. Nibh praesent tristique magna sit amet purus gravida. Lacinia quis vel eros donec ac odio tempor orci. Lectus sit amet est placerat in. Euismod quis viverra nibh cras pulvinar mattis nunc. Auctor elit sed vulputate mi. Turpis in eu mi bibendum neque egestas." +
                "\n\n" + "Tortor dignissim convallis aenean et tortor at risus. Sed nisi lacus sed viverra tellus in hac. Elementum nisi quis eleifend quam adipiscing vitae. In hac habitasse platea dictumst quisque sagittis purus sit. Hendrerit gravida rutrum quisque non tellus orci. Viverra suspendisse potenti nullam ac tortor vitae. Ut aliquam purus sit amet luctus venenatis lectus magna. Consequat nisl vel pretium lectus quam id leo in vitae. Feugiat in ante metus dictum at tempor commodo ullamcorper a. Mauris ultrices eros in cursus turpis. Ultrices sagittis orci a scelerisque purus semper eget. Eu turpis egestas pretium aenean pharetra magna ac. Sapien et ligula ullamcorper malesuada. Pellentesque dignissim enim sit amet. Ac tortor dignissim convallis aenean et tortor at." +
                "\n\n" + "Ipsum dolor sit amet consectetur adipiscing elit. Nunc mi ipsum faucibus vitae aliquet. Ipsum dolor sit amet consectetur adipiscing elit duis tristique sollicitudin. Odio ut sem nulla pharetra diam sit. Placerat in egestas erat imperdiet sed euismod nisi. Donec ultrices tincidunt arcu non sodales neque sodales ut. Ultrices dui sapien eget mi proin sed libero. Lacus sed turpis tincidunt id aliquet risus. Sollicitudin nibh sit amet commodo nulla. Amet porttitor eget dolor morbi non arcu risus quis varius. Vulputate odio ut enim blandit. In fermentum posuere urna nec tincidunt praesent semper feugiat. Varius sit amet mattis vulputate enim nulla aliquet. Quisque sagittis purus sit amet volutpat consequat mauris. Montes nascetur ridiculus mus mauris vitae. Amet mauris commodo quis imperdiet massa tincidunt. Sed risus ultricies tristique nulla aliquet enim tortor at." +
                "\n\n" + "Volutpat est velit egestas dui id ornare arcu. Velit dignissim sodales ut eu sem integer vitae justo eget. Interdum consectetur libero id faucibus nisl. At quis risus sed vulputate odio ut. Amet consectetur adipiscing elit ut aliquam purus sit amet. Cum sociis natoque penatibus et magnis dis parturient montes nascetur. Ut tellus elementum sagittis vitae et. Viverra tellus in hac habitasse platea dictumst vestibulum rhoncus. Morbi non arcu risus quis. Praesent tristique magna sit amet purus gravida quis blandit turpis. Id volutpat lacus laoreet non curabitur gravida arcu. Cras fermentum odio eu feugiat pretium nibh ipsum consequat nisl. Sit amet volutpat consequat mauris nunc congue nisi." +
                "\n\n" + "Posuere ac ut consequat semper. Duis ut diam quam nulla porttitor massa id neque. Dictum non consectetur a erat nam at lectus urna duis. Elit scelerisque mauris pellentesque pulvinar pellentesque habitant morbi. Sit amet purus gravida quis blandit turpis cursus in hac. Molestie a iaculis at erat pellentesque adipiscing commodo elit. Nulla facilisi nullam vehicula ipsum a arcu cursus vitae. Proin fermentum leo vel orci porta non pulvinar. Placerat orci nulla pellentesque dignissim enim sit. Arcu dui vivamus arcu felis bibendum. Tellus rutrum tellus pellentesque eu tincidunt. Vitae elementum curabitur vitae nunc." +
                "\n\n" + "At imperdiet dui accumsan sit amet nulla facilisi morbi tempus. Aliquet eget sit amet tellus cras adipiscing enim eu turpis. Etiam dignissim diam quis enim lobortis scelerisque fermentum. Sed viverra tellus in hac habitasse. Rhoncus mattis rhoncus urna neque viverra justo nec. Diam maecenas ultricies mi eget mauris pharetra. Lorem mollis aliquam ut porttitor leo a diam sollicitudin tempor. Ipsum nunc aliquet bibendum enim. Rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui. Feugiat in fermentum posuere urna nec tincidunt praesent semper feugiat. Tempor commodo ullamcorper a lacus vestibulum sed. Purus in massa tempor nec feugiat nisl pretium fusce. Condimentum id venenatis a condimentum vitae. Massa vitae tortor condimentum lacinia quis vel." +
                "\n\n" + "Condimentum mattis pellentesque id nibh tortor id aliquet. Suspendisse faucibus interdum posuere lorem ipsum. Platea dictumst quisque sagittis purus sit amet volutpat. Proin libero nunc consequat interdum varius sit amet mattis. Vivamus arcu felis bibendum ut tristique et. Pulvinar elementum integer enim neque volutpat ac tincidunt. Ornare lectus sit amet est placerat. Sed arcu non odio euismod lacinia at. Placerat orci nulla pellentesque dignissim enim sit. Eros donec ac odio tempor orci dapibus ultrices. Dolor sit amet consectetur adipiscing elit ut aliquam purus sit. Dolor sit amet consectetur adipiscing elit duis tristique sollicitudin nibh. Leo a diam sollicitudin tempor id eu nisl nunc. Mus mauris vitae ultricies leo integer malesuada nunc vel." +
                "\n\n" + "Felis bibendum ut tristique et egestas quis ipsum suspendisse ultrices. Viverra accumsan in nisl nisi. In massa tempor nec feugiat nisl pretium. Et netus et malesuada fames ac turpis egestas maecenas. Ut enim blandit volutpat maecenas volutpat blandit aliquam etiam erat. Est sit amet facilisis magna etiam tempor orci eu. Et netus et malesuada fames ac turpis egestas sed tempus. Maecenas pharetra convallis posuere morbi leo urna. Enim nec dui nunc mattis. Convallis a cras semper auctor neque.";
        }

        public ICollection<Article> GetBookmarkedArticles()
        {
            var a = this.GetRecommendedArticles();
            var b = this.GetPopularArticles();
            return a.Concat(b).ToList();
        }
    }
}
