using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseclassDataContext test = new DatabaseclassDataContext();
            //IQueryable<Testing> value=test.Testings.Where(test1 => test1.PinCode > 123456);
            //var valueTest = value1.OrderByDescending(g=>g.PinCode); 
            //var valueSkipAndTake = value1.Take(1);

            ///extention method practice
            //var check = "";
            //var testingnull = check.IsnullTest();
            //var valueSkipAndTake = value1.Skip(1).Take(1);
            //IEnumerable<Testing> value1 = test.Testings
            //   .AsEnumerable()
            //   .Where(test1 => test1.PinCode > 700);
            IEnumerable<Testing> value1 = Enumerable.Where(test.Testings, test1 => test1.PinCode > 700);

            AccessCar accessCar = new AccessCar();
            var val = accessCar.carspractice();

                var res = val.Select(x => x.model5);
            var selectManyresult = val.SelectMany(x => x.model5);

            ///anonymous linQ
            var selectManyanonamous = val.Select(x => new
            {
                compay =x.model5,
                compay1 = x.model5
            }
            );

            dgvResult.DataSource = value1;
            dgvResult.DataBind();
        }
    }
}