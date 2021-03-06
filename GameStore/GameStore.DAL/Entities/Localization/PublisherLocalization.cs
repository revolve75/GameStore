﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.DAL.Entities.Localization
{
    public class PublisherLocalization : LocalizationEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PublisherLocalizationId { get; set; }

        [MaxLength(450)]
        public string CompanyName { get; set; }

        public string Description { get; set; }
        
        public int PublisherId { get; set; }

        [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { get; set; }
    }
}
