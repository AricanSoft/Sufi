using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ElementiumBrowser.Functions;
namespace ElementiumBrowser.Controllers
{
    public class history
    {

        public static string view()
        {
            return Functions.view("history", "Geçmiş");
        }


        public static string getlist()
        {

            string historyData = "";
            
            foreach (string history in Properties.Settings.Default.History)
            {
                string[] splitted_history = history.Split(',');

                historyData += " <tr id=\"history-" + splitted_history[0] + "\">" // id
                              + "<td> <input type=\"hidden\" value=\"" + splitted_history[0] + "\" id=\"row_id\">" + splitted_history[3] + "</td>" // isim
                              + "<td>" + splitted_history[1] + "</td>" // url
                              + "<td>" + splitted_history[2] + "</td>" // tarih
                              + "<td><button class=\"remove-button\">X</button></td>"
                              + "</tr>";
            }


            return historyData;
        }

        public static bool addHistory(string _url, string _visit_date, string _page_title)
        {

            int entryID = Properties.Settings.Default.History.Count + 1;

            if (Functions.is_set(_url) && Functions.is_set(_visit_date) && Functions.is_set(_page_title))
            {
                Properties.Settings.Default.History.Add(entryID + "," + _url + "," + _visit_date + "," + _page_title);
                return true;
            }
            else
            {
                return false;
            }

        }

        public static string deletehistory(string id)
        {
            try {
                foreach (string history in Properties.Settings.Default.History)
                {
                    string[] splitted_history = history.Split(',');
                    if (splitted_history[0] == id)
                    {
                        Properties.Settings.Default.History.Remove(history);
                    }
                }
                
            }
            catch
            {

            }
            return Functions.view("history", "Geçmiş");
        }

        public static string clearURL(string _url) {

            Uri process_uri = new Uri(_url);
            return process_uri.Host;

        }


    }
}
