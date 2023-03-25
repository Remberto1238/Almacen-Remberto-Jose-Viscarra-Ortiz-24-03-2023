using System.Text;
using System.Threading.Tasks;
using Almacen.Models;


namespace Almacen.DAO
{
    internal class CrudProductos
    {
        public void AgregarUsuario(TablaProducto ParametroProductos)
        {

            using (AlmacenContext db = new AlmacenContext())
            {
                TablaProducto productos = new TablaProducto();
                productos.Nombre = ParametroProductos.Nombre;
                productos.Descripcion = ParametroProductos.Descripcion;
                productos.Precio = ParametroProductos.Precio;
                productos.Stock = ParametroProductos.Stock;
                db.Add(productos);
                db.SaveChanges();
            }
        }
    }
}
