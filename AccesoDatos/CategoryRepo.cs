using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CategoryRepo
    {
        public List<Categoria> ObtenerTodo() 
        {
            using (var conexion = DataBasecs.GetSqlConnection()) 
            {
                String SelectAll = "";
                SelectAll = SelectAll + "SELECT [CategoryID] " + "\n";
                SelectAll = SelectAll + "      ,[CategoryName] " + "\n";
                SelectAll = SelectAll + "      ,[Description] " + "\n";
                SelectAll = SelectAll + "      ,[Picture] " + "\n";
                SelectAll = SelectAll + "  FROM [dbo].[Categories]";

                var Categoriass = conexion.Query<Categoria>(SelectAll).ToList();
                return Categoriass;
            }
        }

        public Categoria ObtenerPoeID(int id) 
        {
            using (var conexion = DataBasecs.GetSqlConnection())
            {

                String SelectID = "";
                SelectID = SelectID + "SELECT [CategoryID] " + "\n";
                SelectID = SelectID + "      ,[CategoryName] " + "\n";
                SelectID = SelectID + "      ,[Description] " + "\n";
                SelectID = SelectID + "      ,[Picture] " + "\n";
                SelectID = SelectID + "  FROM [dbo].[Categories] " + "\n";
                SelectID = SelectID + "  WHERE CategoryID = @CategoryID";

                var Categoriass = conexion.QueryFirstOrDefault<Categoria>(SelectID, new { CategoryID = id });
                return Categoriass;
            }   
        }

        public int InsertarCat(Categoria categoria)
        {
            using (var conexion = DataBasecs.GetSqlConnection())
            {
                string Insertar = "";
                Insertar += "INSERT INTO [dbo].[Categories] ";
                Insertar += "(CategoryName, Description, Picture) ";
                Insertar += "VALUES ";
                Insertar += "(@CategoryName, @Description, @Picture);";

                var filasInsertadas = conexion.Execute(Insertar, new
                {
                    CategoryName = categoria.CategoryName,
                    Description = categoria.Description,
                    Picture = categoria.Picture
                });

                return filasInsertadas;
            }
        }
        public int ActualizarCategoria(Categoria categoria)
        {
            using (var conexion = DataBasecs.GetSqlConnection())
            {
                string UpdateaCate = "";
                UpdateaCate += "UPDATE [dbo].[Categories] ";
                UpdateaCate += "SET CategoryName = @CategoryName, ";
                UpdateaCate += "Description = @Description, ";
                UpdateaCate += "Picture = @Picture ";
                UpdateaCate += "WHERE CategoryID = @CategoryID;";

                var filasActualizadas = conexion.Execute(UpdateaCate, new
                {
                    CategoryID = categoria.CategoryID,
                    CategoryName = categoria.CategoryName,
                    Description = categoria.Description,
                    Picture = categoria.Picture
                });

                return filasActualizadas; 
            }
        }

    }
}
