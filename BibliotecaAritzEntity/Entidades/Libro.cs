//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Libro : IEquatable<Libro>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Libro()
        {
            this.LibrosLectores = new HashSet<LibrosLectores>();
            this.Autores = new HashSet<Autor>();
            this.Categorias = new HashSet<Categoria>();
        }

        public Libro(string isbn, string titulo, string editorial, string sinopsis, string caratula, int? unidades, string disponibilidad, ICollection<Autor> autores, ICollection<Categoria> categorias) : this(isbn, titulo, editorial, sinopsis, caratula, unidades, disponibilidad)
        {
            Autores = autores;
            Categorias = categorias;
        }

        public Libro(string isbn, string titulo, string editorial, string sinopsis, string caratula, int? unidades, string disponibilidad)
        {
            Isbn = isbn;
            Titulo = titulo;
            Editorial = editorial;
            Sinopsis = sinopsis;
            Caratula = caratula;
            Unidades = unidades;
            Disponibilidad = disponibilidad;
        }

        public Libro(string isbn, string titulo, string editorial, string sinopsis, string caratula, int? unidades, string disponibilidad, ICollection<LibrosLectores> librosLectores, ICollection<Autor> autores, ICollection<Categoria> categorias)
        {
            Isbn = isbn;
            Titulo = titulo;
            Editorial = editorial;
            Sinopsis = sinopsis;
            Caratula = caratula;
            Unidades = unidades;
            Disponibilidad = disponibilidad;
            LibrosLectores = librosLectores;
            Autores = autores;
            Categorias = categorias;
        }

        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Sinopsis { get; set; }
        public string Caratula { get; set; }
        public Nullable<int> Unidades { get; set; }
        public string Disponibilidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LibrosLectores> LibrosLectores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autor> Autores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Categoria> Categorias { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Libro);
        }

        public bool Equals(Libro other)
        {
            return other != null &&
                   Isbn == other.Isbn;
        }

        public override int GetHashCode()
        {
            return 2140778025 + EqualityComparer<string>.Default.GetHashCode(Isbn);
        }
    }
}
