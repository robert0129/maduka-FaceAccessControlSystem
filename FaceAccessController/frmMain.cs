﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using Newtonsoft.Json;

namespace FaceAccessController
{
    public partial class frmMain : Base.BaseForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Models.CognitiveModels.Setup objSetup = new Models.CognitiveModels.Setup()
        {
            EmotionApiKey = "",
            FaceApiKey = "",
        };

        /// <summary>
        /// 表單讀取的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 離開的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 設定Microsoft Cognitive的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mCognitive_Click(object sender, EventArgs e)
        {
            Forms.frmCognitive objCognitive = new Forms.frmCognitive();
            objCognitive.MdiParent = this;
            objCognitive.SetupConfig = objSetup;
            objCognitive.Show();
        }

        /// <summary>
        /// 開啟WebCam的畫面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mWebCam_Click(object sender, EventArgs e)
        {
            Forms.frmCam objCam = new Forms.frmCam();
            objCam.MdiParent = this;
            objCam.Show();
        }
    }
}