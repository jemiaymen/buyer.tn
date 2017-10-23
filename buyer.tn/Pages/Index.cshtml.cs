using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using buyer.tn.Helpers;

namespace buyer.tn.Pages
{
    public class IndexModel : BasePageModel
    {
        public class MenuJson    
        {   
            public string mtext { get; set; } 
            public int pid { get; set; }  
            public string parent { get; set; }  
            public string url { get; set; }

            public MenuJson()
            {
                parent = null;
                url = null;
            }
        }

        public class ListTemplate
        {
            public string title { get; set; }
            public string img { get; set; }
            public string url { get; set; }
            public string price { get; set; }
            public string date { get; set; }
        }

        public class ListTemplateModal
        {
            public List<ListTemplate> listTempSource = new List<ListTemplate>();
            public List<ListTemplate> setListTempSource()
            {

                listTempSource.Add(new ListTemplate { title = "BMW a vendre", img = "images/test.jpg", url = "/Contact", price = "24 000" , date = "12/2/2017" });
                listTempSource.Add(new ListTemplate { title = "BMW a vendre", img = "images/test.jpg", url = "/Contact", price = "24 000", date = "12/2/2017" });
                listTempSource.Add(new ListTemplate { title = "BMW a vendre", img = "images/test.jpg", url = "/Contact", price = "24 000", date = "12/2/2017" });
                listTempSource.Add(new ListTemplate { title = "BMW a vendre", img = "images/test.jpg", url = "/Contact", price = "24 000", date = "12/2/2017" });
                listTempSource.Add(new ListTemplate { title = "BMW a vendre", img = "images/test.jpg", url = "/Contact", price = "24 000", date = "12/2/2017" });
                listTempSource.Add(new ListTemplate { title = "BMW a vendre", img = "images/test.jpg", url = "/Contact", price = "24 000", date = "12/2/2017" });
                return listTempSource;
            }
            public void clearSource()
            {
                listTempSource.Clear();
            }
        }

             
        public void OnGet()
        {
            List<MenuJson> menu = new List<MenuJson>();           
            menu.Add(new MenuJson { pid = 1, mtext = "Group A", parent = null }); 
            menu.Add(new MenuJson { pid = 2, mtext = "Group B", parent = null });
            menu.Add(new MenuJson { pid = 3, mtext = "Group C", parent = null });  
            menu.Add(new MenuJson { pid = 4, mtext = "Group D", parent = null });  
            menu.Add(new MenuJson { pid = 5, mtext = "Group E", parent = null });  
            menu.Add(new MenuJson { pid = 11, parent = "1", mtext = "Algeria" , url = "/Algeria"});  
            menu.Add(new MenuJson { pid = 12, parent = "1", mtext = "Armenia" , url = "/About" });   
            menu.Add(new MenuJson { pid = 13, parent = "1", mtext = "Bangladesh" , url = "/Contact" }); 
            menu.Add(new MenuJson { pid = 14, parent = "1", mtext = "Cuba" , url = "/Index"});      
            menu.Add(new MenuJson { pid = 15, parent = "2", mtext = "Denmark" });   
            menu.Add(new MenuJson { pid = 16, parent = "2", mtext = "Egypt" });     
            menu.Add(new MenuJson { pid = 17, parent = "3", mtext = "Finland" });   
            menu.Add(new MenuJson { pid = 18, parent = "3", mtext = "India" });     
            menu.Add(new MenuJson { pid = 19, parent = "3", mtext = "Malaysia" });   
            menu.Add(new MenuJson { pid = 20, parent = "4", mtext = "New Zealand" });
            menu.Add(new MenuJson { pid = 21, parent = "4", mtext = "Norway" });      
            menu.Add(new MenuJson { pid = 22, parent = "4", mtext = "Romania" });     
            menu.Add(new MenuJson { pid = 23, parent = "5", mtext = "Singapore" });   
            menu.Add(new MenuJson { pid = 24, parent = "5", mtext = "Thailand" });      
            menu.Add(new MenuJson { pid = 25, parent = "5", mtext = "Ukraine" });     
            menu.Add(new MenuJson { pid = 26, parent = "11", mtext = "First Place" }); 
            menu.Add(new MenuJson { pid = 27, parent = "12", mtext = "Second Place" }); 
            menu.Add(new MenuJson { pid = 28, parent = "13", mtext = "Third place" });     
            menu.Add(new MenuJson { pid = 29, parent = "14", mtext = "Fourth Place" });  
            menu.Add(new MenuJson { pid = 30, parent = "15", mtext = "First Place" });    
            menu.Add(new MenuJson { pid = 31, parent = "16", mtext = "Second Place" }); 
            menu.Add(new MenuJson { pid = 32, parent = "17", mtext = "Third Place" });     
            menu.Add(new MenuJson { pid = 33, parent = "18", mtext = "First Place" });    
            menu.Add(new MenuJson { pid = 34, parent = "19", mtext = "Second Place" });
            menu.Add(new MenuJson { pid = 36, parent = "21", mtext = "Second Place" });   
            menu.Add(new MenuJson { pid = 37, parent = "22", mtext = "Third place" });
            menu.Add(new MenuJson { pid = 39, parent = "24", mtext = "First Place" });    
            menu.Add(new MenuJson { pid = 40, parent = "25", mtext = "Second Place" });  

            ViewBag.menusource = menu;

            var lst = new ListTemplateModal();

            ViewBag.lst = lst.setListTempSource();

        }
    }
}
