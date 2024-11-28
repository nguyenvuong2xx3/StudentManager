//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagement.Models
{
    using StudentManagement.ViewModels;
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher : BaseViewModel
    {
        public Teacher()
        {
            this.Classes = new HashSet<Class>();
            this.SubjectClasses = new HashSet<SubjectClass>();
        }
    
        private System.Guid _id { get; set; }
        public System.Guid Id { get => _id; set { _id = value; OnPropertyChanged(); } }
        private Nullable<System.Guid> _idFaculty { get; set; }
        public Nullable<System.Guid> IdFaculty { get => _idFaculty; set { _idFaculty = value; OnPropertyChanged(); } }
        private Nullable<System.Guid> _idUsers { get; set; }
        public Nullable<System.Guid> IdUsers { get => _idUsers; set { _idUsers = value; OnPropertyChanged(); } }
    
        public virtual ICollection<Class> Classes { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<SubjectClass> SubjectClasses { get; set; }
    }
}