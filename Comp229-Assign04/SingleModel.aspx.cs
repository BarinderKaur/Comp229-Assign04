using System;
using Comp229_Assign04.Models;

namespace Comp229_Assign04
{
    public partial class _Default : System.Web.UI.Page
    {
        private Model _Model;
        protected void Page_Load(object sender, EventArgs e)
        {
             var name = Request.QueryString["name"];
            var faction = Request.QueryString["faction"];
            if (String.IsNullOrEmpty(name))
            {
                Response.Redirect("~/Home_Page.aspx");
                return;
            }
           // _Model = Global.Model.FirstOrDefault(tModel => tModel.name == name && tModel.faction == faction);
            SetBindings();
            //name_row.Visible = true;
            //row1.Visible = false;

        }
        private void SetBindings()
        {
            modelImg.ImageUrl = _Model.imageUrl;
            nameLabel.Text = _Model.name;
            factionLabel.Text = _Model.faction;
            rankLabel.Text = _Model.rank.ToString();
            baseLabel.Text = _Model._base + "mm";
            sizeLabel.Text = _Model.size.ToString();
            deploymentzoneLabel.Text = _Model.deploymentZone;

            traitsRepeater.DataSource = _Model.traits;    // you don't have the repeaters in your singleModel page
            traitsRepeater.DataBind();

            typeRepeater.DataSource = _Model.types; // you don't have the repeaters in your singleModel page
            typeRepeater.DataBind();

            defenceChartRepeater.DataSource = _Model.defenseChart;
            defenceChartRepeater.DataBind();
            mobilityLabel.Text = _Model.mobility.ToString();
            willpowerLabel.Text = _Model.willpower.ToString();
            resilienceLabel.Text = _Model.resiliance.ToString();
            woundsLabel.Text = _Model.wounds.ToString();
            actionRepeater.DataSource = _Model.actions;
            actionRepeater.DataBind();

            specialAbilitiesRepeater.DataSource = _Model.specialAbilities;
            specialAbilitiesRepeater.DataBind();

        }
        protected void UpdateButton_Click(object sender, EventArgs e)

        {

            _Model.name = "new name";
            var one = Global.Models;
            var two = 2;
            Global.UpdateNewJsonFile();

        }







    }
        }
    }
}