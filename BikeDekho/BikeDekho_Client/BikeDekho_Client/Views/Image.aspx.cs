﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BikeDekho_Client.Views
{
    public partial class Image : System.Web.UI.Page
    {
        BikeDekhoService.ServiceClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new BikeDekhoService.ServiceClient();
            int id = int.Parse(Request.QueryString["id"].ToString());
            byte[] imageByte = client.GetImage(id);
            string base64String = Convert.ToBase64String(imageByte, 0, imageByte.Length);
            Image1.ImageUrl = "data:image/png;base64," + base64String;
        }
    }
}