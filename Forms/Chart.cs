using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Chart : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Food> food = Software.Database.SQL.FoodDB.GetAllFoods();

        public Chart()
        {
            InitializeComponent();
            chart1.DataSource = food;


            chart1.Series["Price"].XValueMember =  "Price";
            chart1.Series["Price"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

        }

    }

        
    }

