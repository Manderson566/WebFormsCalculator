using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string addition;
    public string Equation;
    public string Answer1;
    public string Answer2;
    public double Answer;
    public double ans1;
    public double ans2;
    public List<string> Operators = new List<string>
    {
        "Addition +",
        "Subtraction -",
        "Multiplication *",
        "Division /"
    };
    public string DropDown = "";


    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {

            Answer1 = Request.Form["Number1"];
            Answer2 = Request.Form["Number2"];
            DropDown = Request.Form["DropDown"];
            while (Answer1 == "" || Answer2 == "")
             Answer = 0;
            string plus = "+";
            string minus = "-";
            string multiply = "*";
            string divide = "/";
            ans1 = double.Parse(Answer1);
            ans2 = double.Parse(Answer2);
            foreach (var operation in Operators)
            {
                if (Request.Form["DropDown"] == "Addition +")
                {
                    Answer = ans1 + ans2;
                    Equation = Answer1 + plus + Answer2;
                }
                else if (Request.Form["DropDown"] == "Subtraction -")
                {
                    Answer = ans1 - ans2;
                    Equation = Answer1 + minus + Answer2;
                }
                else if (Request.Form["DropDown"] == "Multiplication *")
                {
                    Answer = ans1 * ans2;
                    Equation = Answer1 + multiply + Answer2;
                }
                else if (Request.Form["DropDown"] == "Division /")
                {
                    Answer = ans1 / ans2;
                    Equation = Answer1 + divide + Answer2;
                }
            }
        }
    }

}





