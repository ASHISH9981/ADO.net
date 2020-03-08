using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class AccessCar
    {
        public List<Model> carspractice()
        {

            List<Model> carModelList = new List<Model>()
        {  new Model(){
            model1="ab",
            model2="cd",
            model3="ef",
            model4="gh",
            model5 =new List<cars2>(){
                new cars2()
                {
                   farari="best",
                   hero="avg",
                   splender="normal"
                }
            },
            model6 = new List<cars1>(){
                new cars1(){
                    bmw="good milaze",
                    model3="fastest",
                    suzuky= new List<engin>(){
                    new engin(){
                        cc100="fast",
                        CC250="very"
                    }
                    }

                }

            }

        },
        new Model(){
            model1="abc",
            model2="cde",
            model3="efg",
            model4="ghi",
            model5 =new List<cars2>(){
                new cars2()
                {
                   farari="besti",
                   hero="avgu",
                   splender="normal4"
                }
            },
            model6 = new List<cars1>(){
                new cars1(){
                    bmw="good milaze5",
                    model3="fastest7",
                    suzuky= new List<engin>(){
                    new engin(){
                        cc100="fast7",
                        CC250="very6"
                    }
                    }

                }

            }

        }
        };
            return carModelList;
        }
       
    }
    
}