using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Model
    {
        public string model1 { get; set; }
        public string model2 { get; set; }
        public string model3 { get; set; }
        public string model4 { get; set; }
        public List<cars2> model5 { get; set; }
        public List<cars1> model6 { get; set; }

    }
    public class cars1
    {
        public List<engin> suzuky { get; set; }
        public string bmw { get; set; }
        public string model3 { get; set; }

    }

    public class engin
    {
        public string CC250 { get; set; }
        public string cc100 { get; set; }

    }

    public class cars2
    {
        public string splender { get; set; }
        public string hero { get; set; }
        public string farari { get; set; }

    }

}