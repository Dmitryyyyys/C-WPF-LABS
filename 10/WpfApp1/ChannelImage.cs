using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfApp1
{
    internal class ChannelImage //рисунок канала
    {
        [Key]
        [ForeignKey("Channel")]
        public int Id { get; set; }
        public string ImgTitle { get; set; } //название канала
        public string ImgLink { get; set; } //ссылка на сайт
        public string ImgUrl { get; set; } //url картинки
        public Channel Channel { get; set; }

        public ChannelImage()
        {
            ImgTitle = "";  
            ImgLink = "";
            ImgUrl = "";
        }
    }
}