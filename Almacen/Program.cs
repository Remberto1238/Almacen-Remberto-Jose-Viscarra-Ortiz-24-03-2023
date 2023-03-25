using Almacen.Models;
using System;
using Almacen.DAO;


using (AlmacenContext db = new AlmacenContext())
{
    TablaProducto producto = new TablaProducto();
    CrudProductos crudProductos = new CrudProductos();

    //Console.WriteLine("Ingrese El Id del Producto: ");
    //producto.Id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese El Nombre del Producto: ");
    producto.Nombre = Console.ReadLine();

    Console.WriteLine("Ingrese la Descripcion del Producto: ");
    producto.Descripcion = Console.ReadLine();

    Console.WriteLine("Ingrese el Precio del Producto: ");
    producto.Precio = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Ingrese la Cantidad de Stock: ");
    producto.Stock = Convert.ToInt32(Console.ReadLine());

    db.TablaProductos.Add(producto);
    db.SaveChanges();
}