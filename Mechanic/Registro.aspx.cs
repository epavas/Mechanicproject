using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Mongodb bd = new Mongodb();
        try
        {
            if (Int32.Parse(experiencia.Text).Equals(""))
            {
                mensaje("Años de experiencia no valido invalido");


            }
            else
            {
                if (bd.find("User", "Correo", correo.Text) == "null")
                {
                    BsonDocument documento = new BsonDocument
           {
           {"Nombre", nom.Text },
           {"Apellido",ape.Text },
           {"Correo",correo.Text },
           {"Contraseña",contra.Text },
           {"Especialidad",carrerasop.SelectedItem.ToString() },
           {"Semestre",experiencia.Text }
           };
                    BsonDocument documento2 = new BsonDocument
           {
           {"Nombre", nom.Text },
           {"Apellido",ape.Text },
           {"Correo",correo.Text },
           {"Especialidad",carrerasop.SelectedItem.ToString() },
           {"Semestre",experiencia.Text }
           };
                    bd.insert("User", documento);
                    bd.insert("UserF", documento2);
                    mensaje("Registro Exitoso");
                    Session["Usuario"] = nom.Text;
                    Session["Apellido"] = ape.Text;
                    Session["Correo"] = correo.Text;
                    Session["Carrera"] = carrerasop.SelectedItem.ToString();
                    Session["Semestre"] = experiencia.Text;
                    nom.Text = "";
                    ape.Text = "";
                    correo.Text = "";
                    contra.Text = "";
                    carrerasop.SelectedValue = "1";
                    experiencia.Text = "";
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    mensaje("Ya existe un usuario con este correo electronico, intene nuevamente");
                }
            }
        }
        catch (Exception)
        {
            mensaje("Campos no validos ");
            //throw;

        }


    }
    public void mensaje(String mensaje)
    {
        string script = "alert(\"" + mensaje + "\");";
        ScriptManager.RegisterStartupScript(this, GetType(),
                              "ServerControlScript", script, true);
    }
}