using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Acceso
    {
        Gestor nuevoAcceso = new Gestor(out string mensaje);
        public List<Categoria> DevolverCategorias()
        {
            return nuevoAcceso.DevolverCategorias();
        }
        public List<Autor> DevolverAutores()
        {
            return nuevoAcceso.DevolverAutores();
        }
        public List<Libro> DevolverLibros()
        {
            return nuevoAcceso.DevolverLibros();
        }
        public string AnadirAutor(int id, string nombre)
        {
            return nuevoAcceso.AnadirAutor(id, nombre);
        }
        public string BorrarLibro(string isbn)
        {
            return nuevoAcceso.BorrarLibro(isbn);
        }
        public string AnadirLibro(string isbn, string titulo, string editorial, string sinopsis, string caratula, int unidades, string disponibilidad, List<Categoria> ListaC, List<Autor> ListaAut)
        {
            return nuevoAcceso.AnadirLibro(isbn, titulo,editorial,sinopsis,caratula,unidades,disponibilidad,ListaC,ListaAut);
        }
        public List<Libro> DevolverLibrosPorTitulo(string trozoLibro)
        {
            return nuevoAcceso.DevolverLibrosPorTitulo(trozoLibro);
        }
        public string HacerPrestamo(List<Libro>librosParaPrestar,int nCarnet)
        {
            return nuevoAcceso.HacerPrestamo(librosParaPrestar, nCarnet);
        }
        public List<LibrosLectores> DevolverPrestamos(int nCarnet, out string msg)
        {
            return nuevoAcceso.DevolverPrestamos(nCarnet, out msg);
        }
        public string RealizarDevolucion(List<LibrosLectores> LibrosADevolver)
        {
            return nuevoAcceso.RealizarDevolucion(LibrosADevolver);
        }
        public List<Libro> ListaLibrosPorCategoria(int idCat,int seleccion, out string msg)
        {
            return nuevoAcceso.ListaLibrosPorCategoria(idCat, seleccion, out msg);
        }
        public List<Autor> DevolverAutoresPorNombre(string nombreAutor)
        {
            return nuevoAcceso.DevolverAutoresPorNombre(nombreAutor);
        }
        public List<Libro> DevolverLibrosDeAutor(int id, out string msg)
        {
            return nuevoAcceso.DevolverLibrosDeAutor(id, out msg);
        }
        public List<LibrosLectores> DevolverLibrosMorosos(out string msg)
        {
            return nuevoAcceso.DevolverLibrosMorosos(out msg);
        }
    }
}
