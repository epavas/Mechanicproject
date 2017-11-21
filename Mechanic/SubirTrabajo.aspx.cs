using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SubirTrabajo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Default.aspx");
            }
        }
        catch (Exception)
        {

            throw;
        }

    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Empleos.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("Index.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Mongodb bd = new Mongodb();
        try
        {
            BsonDocument documento = new BsonDocument
        {
            {"Empresa", nom.Text },
            {"Cargo",car.Text },
            {"Fecha Inicio",fechafin.Text },
            {"Fecha Fin",fechafin.Text },
            {"Correo Registrado",Session["Correo"].ToString() },
        };
            bd.insert("Trabajo", documento);
            mensaje("Trabajo subido con exito");
            nom.Text = "";
            car.Text = "";
            fechaini.Text = "";
            fechafin.Text = "";
        }
        catch (Exception)
        {

            throw;
        }

    }
    public void mensaje(String mensaje)
    {
        string script = "alert(\"" + mensaje + "\");";
        ScriptManager.RegisterStartupScript(this, GetType(),
                              "ServerControlScript", script, true);
    }
}