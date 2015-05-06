using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            TimeSpan myTimeSpan;

            myTimeSpan = secondCalendar.SelectedDate.Subtract(firstCalendar.SelectedDate);

            if(myTimeSpan.TotalDays < 0)
                myTimeSpan = firstCalendar.SelectedDate.Subtract(secondCalendar.SelectedDate);

            resultLabel.Text = myTimeSpan.TotalDays.ToString();
        }
    }
}