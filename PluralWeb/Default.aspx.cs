using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity.Design;

namespace PluralWeb
{
    public static class plural
    {
        /// <summary>
        /// Returns the plural form of the specified word.
        /// </summary>
        /// <param name="count">How many of the specified word there are. A count equal to 1 will not pluralize the specified word.</param>
        /// <returns>A string that is the plural form of the input parameter.</returns>
        public static string ToPlural(this string @this, int count = 0)
        {
            return count == 1 ? @this : System.Data.Entity.Design.PluralizationServices.PluralizationService.CreateService(new System.Globalization.CultureInfo("en-US")).Pluralize(@this);
        }

    }
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //----Pluralize words
           // for (int i = 1; i < 20; i++)
         //   {
                //Console.Write("Please type in a word that you would like pluralized... ");
                string theWord = TextBox1.Text;
                string plural = theWord.ToPlural();
                // Console.WriteLine(theWord + " in plural form is " + theWord.ToPlural());
                theWord = theWord + "  in plural form is " + plural;
                TextBox1.Text = theWord;
          //  }
           // Console.ReadLine();  //keeps console screen paused and displayed until user presses a key

        }
    }
}