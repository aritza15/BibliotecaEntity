using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Gestor
    {
        BibliotecaRecuperacionAritzEntities BibliotecaEntities;

        public Gestor(out string mensaje)
        {
            mensaje = "";
            try
            {
                BibliotecaEntities = new BibliotecaRecuperacionAritzEntities();
            }
            catch (Exception)
            {
                mensaje = "No se a podido conectar con la base de datos, contacte con el administrador";
            }
        }
        public List<Categoria> DevolverCategorias()
        {
            return BibliotecaEntities.Categorias.ToList();
        }
        public List<Autor> DevolverAutores()
        {
            return BibliotecaEntities.Autores.ToList();
        }
        public List<Libro> DevolverLibros()
        {
            return BibliotecaEntities.Libros.ToList();
        }
        public string AnadirAutor(int id, string nombre)
        {
            if(id == 0)
            {
                return "Debes de introducir un id";
            }
            if (BibliotecaEntities.Autores.Find(id) != null)
            {
                return "El id introducido ya existe";
            }
            try
            {
                BibliotecaEntities.Autores.Add(new Autor(id,nombre));
                int cambios = BibliotecaEntities.SaveChanges();
                if (cambios == 0) return "Error al añadir";
                return "Añadido correctamente";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
           
        }
        public string AnadirLibro(string isbn, string titulo, string editorial,string sinopsis, string caratula,int unidades, string disponibilidad, List<Categoria> ListaC, List<Autor> ListaAut)
        {
            if(string.IsNullOrWhiteSpace(isbn) || string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(editorial) || string.IsNullOrWhiteSpace(sinopsis)||string.IsNullOrWhiteSpace(caratula)||string.IsNullOrWhiteSpace(disponibilidad))
            {
                return "Debes de rellenar todos los campos.";
            }
            if(ListaAut==null || ListaC == null)
            {
                return "Debes seleccionar los autores y/o las categorias";
            }
            if (BibliotecaEntities.Libros.Find(isbn).Categorias == null)
            {
                return "No existen las categorias";
            }
            if (BibliotecaEntities.Libros.Find(isbn).Autores == null)
            {
                return "No existen los autores";
            }
            if (BibliotecaEntities.Libros.Find(isbn) != null)
            {
                return "El libro que intentas añadir ya existe";
            }
            try
            {
                BibliotecaEntities.Libros.Add(new Libro(isbn,titulo,editorial,sinopsis,caratula,unidades,disponibilidad,ListaAut,ListaC));
                int cambios = BibliotecaEntities.SaveChanges();
                if (cambios == 0) return "Error al añadir";
                return "Añadido correctamente";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
        public string BorrarLibro(string isbn)
        {
            try
            {
                
                Libro libro = BibliotecaEntities.Libros.Find(isbn);
                if (libro.LibrosLectores.Count() > 0)
                {
                    return "No se puede eliminar si tiene unidades prestadas";
                }
                BibliotecaEntities.Libros.Remove(libro);
                int cambios = BibliotecaEntities.SaveChanges();
                if (cambios == 0) return "Error al eliminar";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Eliminado Correctamente";
        }
        public List<Libro> DevolverLibrosPorTitulo(string trozoLibro)
        {
         return BibliotecaEntities.Libros.Where(t => t.Titulo.ToUpper().Contains(trozoLibro.ToUpper())).ToList();           
        }
        public string HacerPrestamo(List<Libro>Libros, int nCarnet)
        {
            if (nCarnet == 0)
            {
                return "Introduce datos en todos los campos";
            }
            Lector lector = BibliotecaEntities.Lectores.Find(nCarnet);
            if (lector == null)
            {
                return "No existe ningun lector con ese numero";
            }
            if(Libros == null)
            {
                return "No existen esos libros";
            }
            foreach (Libro lib in Libros)
            {

                if(lib.Disponibilidad!= "Prestable")
                {
                    return $"El libro {lib.Titulo} no es prestable";
                }
                if(lib.Unidades == 0)
                {
                    return $"No se encuentran unidades del libro {lib.Titulo}";
                }
                if (BibliotecaEntities.LibrosLectores1.Find(lib.Isbn,nCarnet)!=null)
                {
                    return "Ya has pedido prestado este libro";
                }
                try
                {
                    BibliotecaEntities.Libros.Find(lib.Isbn).Unidades--;
                    int cambios = BibliotecaEntities.SaveChanges();
                    if (cambios == 0) return "Error al modificar";
                    BibliotecaEntities.LibrosLectores1.Add(new LibrosLectores(lib.Isbn, nCarnet, DateTime.Now, DateTime.Now.AddDays(7)));
                    cambios = BibliotecaEntities.SaveChanges();
                    if (cambios == 0) return "Error al añadir";
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
                
            } 
         
         
            return "";
        }
        public List<LibrosLectores> DevolverPrestamos(int nCarnet, out string msg)
        {
            msg = "";

            if (nCarnet == 0)
            {
                msg = "No se ha introducido ningun número";
                return null;
            }
            List<LibrosLectores> ListaPrestamos = BibliotecaEntities.LibrosLectores1.Where(p => p.NCarnet == nCarnet).ToList();
            if (ListaPrestamos == null)
            {
                msg = "El numero de carnet introducido no tiene ningun prestamo";
                return null;
            }
            return ListaPrestamos;
        }
        public string RealizarDevolucion(List<LibrosLectores> LibrosADevolver)
        {
            if (LibrosADevolver == null)
            {
                return "Debes seleccionar un préstamo a devolver";
            }
            foreach (LibrosLectores libs in LibrosADevolver)
            {
               LibrosLectores libro = BibliotecaEntities.LibrosLectores1.Find(libs.Isbn, libs.NCarnet);
                BibliotecaEntities.LibrosLectores1.Remove(libro);
                BibliotecaEntities.Libros.Find(libs.Isbn).Unidades ++;
                int cambios = BibliotecaEntities.SaveChanges();
                if (cambios == 0) return "Error al modificar";
            }
            
            return "Has devuelto correctamente los libros";
        }
        public List<Libro>ListaLibrosPorCategoria(int idCat,int seleccion,out string msg)
        {
            msg = "";
            var libros = BibliotecaEntities.Categorias.Find(idCat).Libros;
            List<Libro> listaLibros = new List<Libro>();
            if (seleccion == 0)
            {
                msg = "Ha habido un error con la selección.";
                return null;
            }
            if(idCat == 0)
            {
                msg = "No has seleccionado ninguna categoria";
                return null;
            }
            if (seleccion == 1)
            {
                listaLibros = libros.OrderBy(p=>p.Titulo).ToList();       
            }
            if(seleccion == 2)
            {
                listaLibros = libros.Where(p => p.Disponibilidad == "Prestable").OrderBy(p => p.Titulo).ToList();
            }
            if(seleccion == 3)
            {
                listaLibros = libros.Where(p => p.Disponibilidad == "Prestable" && p.Unidades > p.LibrosLectores.Where(a=>p.Isbn==a.Isbn).Count()).OrderBy(p => p.Titulo).ToList();
            }
            return listaLibros;
        }
        public List<Autor> DevolverAutoresPorNombre(string nombreAutor)
        {
            return BibliotecaEntities.Autores.Where(t => t.Nombre.ToUpper().Contains(nombreAutor.ToUpper())).ToList();
        }
        public List<Libro> DevolverLibrosDeAutor(int id, out string msg)
        {
            msg = "";
            var librosAutor = BibliotecaEntities.Autores.Find(id).Libros.ToList();
            if(librosAutor == null)
            {
                msg = "No tiene ningun libro";
                return null;
            }
            else
            {
                return librosAutor;
            }
        }
        public List<LibrosLectores> DevolverLibrosMorosos(out string msg)
        {
            msg = "";
            var librosMorosos =  BibliotecaEntities.LibrosLectores1.Where(p => p.FechaDevolucion < DateTime.Today).OrderBy(p=>p.Libro.Titulo).ToList();
            if (librosMorosos == null)
            {
                msg = "No hay morosos";
                return null;
            }
            else
            {
                return librosMorosos;
            }
        }
    }
}
