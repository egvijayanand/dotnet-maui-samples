using System;
using Newtonsoft.Json;

namespace SpaceXhistory.Models
{
    public class Root
    {
        public Links links { get; set; }
        public object success { get; set; }
        public string name { get; set; }
        public DateTime date_utc { get; set; }
        public DateTime date_local { get; set; }
        public bool upcoming { get; set; }

        [JsonIgnore]
        public string Status
        {
            get
            {
                if (upcoming)
                {
                    return "upcoming";
                }

                if (success is bool value)
                {
                    if (value)
                    {
                        return "successful";
                    }
                    else
                    {
                        return "failed";
                    }
                }

                return "failed";
            }
        }

        [JsonIgnore]
        public Color StatusColor
        {
            get
            {
                if (upcoming)
                {
                    return Color.FromHex("#3a86ff");
                }

                if (success is bool value)
                {
                    if (value)
                    {
                        return Color.FromHex("#76c893");
                    }
                    else
                    {
                        return Color.FromHex("#e63946");
                    }
                }

                return Color.FromHex("#e63946");
            }
        }
    }
}

