﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TruyenKimDung.DAL;

namespace TruyenKimDung.Admin.Truyen
{
    public partial class DanhSachTruyenControl : System.Web.UI.UserControl
    {
        ClsTruyen truyen = new ClsTruyen();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();

            }

        }

        void LoadData()
        {
            rptDSTruyen.DataSource = truyen.HienThiDSTruyen();
            rptDSTruyen.DataBind();
        }
    }
}