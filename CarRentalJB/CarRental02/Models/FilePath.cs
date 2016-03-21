namespace CarRental02.Models
{
    using System.ComponentModel.DataAnnotations;
    public class FilePath
    {
        public int FilePathId { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        public FileType FileType { get; set; }
        public int CarTypeID { get; set; }
        public virtual CarType CarType { get; set; }
    }
}