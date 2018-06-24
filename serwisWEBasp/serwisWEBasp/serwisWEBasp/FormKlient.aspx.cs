using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using serwisWEBasp.ServiceReference;


namespace serwisWEBasp
{
    public partial class FormKlient : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void ButtonKonwertuj_Click(object sender, EventArgs e)
        {
            WebServicePISSoapClient dodaj = new WebServicePISSoapClient();
            double a=Convert.ToDouble(TextBoxTemp.Text);
            double b=a;
            LabelRezultat.Text = a.ToString();

            if (RadioButtonList1.SelectedValue == "Celsjusz")
            {  

                if (RadioButtonList2.SelectedValue == "Fahrenheit")
                {
                    b = dodaj.CelsjuszToFahrenheit(a);
                    //LabelRezultat.Text = b.ToString();
                }
                if (RadioButtonList2.SelectedValue == "Kelwin")
                {
                    b = dodaj.CelsjuszToKelwin(a);
                    //LabelRezultat.Text = b.ToString();
                }
            }

            if (RadioButtonList1.SelectedValue == "Fahrenheit")
            {
                if (RadioButtonList2.SelectedValue == "Celsjusz")
                {
                    b = dodaj.FahrenheitToCelsjusz(a);
                    //LabelRezultat.Text = b.ToString();
                }
                if (RadioButtonList2.SelectedValue == "Kelwin")
                {
                    b = dodaj.FahrenheitToKelwin(a);
                    //LabelRezultat.Text = b.ToString();
                }
            }

            if (RadioButtonList1.SelectedValue == "Kelwin")
            {
                if (RadioButtonList2.SelectedValue == "Celsjusz")
                {
                    b = dodaj.KelwinToCelsjusz(a);
                    //LabelRezultat.Text = b.ToString();
                }
                if (RadioButtonList2.SelectedValue == "Fahrenheit")
                {
                    b = dodaj.KelwinToFahrenheit(a);
                    //LabelRezultat.Text = b.ToString();
                }
            }
            LabelRezultat.Text = (Math.Round(b, 2)).ToString();
        }
    }
}