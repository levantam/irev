﻿using SmartStore.Core.Domain.Catalog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmartStore.Core.Domain.Reviews
{
    [DataContract]
    public class Review: BaseEntity
    {
        public Review()
        {
            IsDelete = false;
            IsActive = true;
        }

        private Product _product;
        private Reviewer _reviewer;
        private ICollection<ReviewImage> _reviewImages;

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Url { get; set; }

        [DataMember]
        public string ShortUrl { get; set; }

        [DataMember]
        public string Cover { get; set; }

        [DataMember]
        public string ShortDescription { get; set; }

        [DataMember]
        public string Description { get; set; } // full description: both image, text

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public bool IsDelete { get; set; }

        [DataMember]
        public bool IsHighlight { get; set; }

        [DataMember]
        public bool IsPremium { get; set; }

        [DataMember]
        public int Rating { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public DateTime UpdatedDate { get; set; }

        [DataMember]
        public string VideoUrl { get; set; }

        [DataMember]
        public string Thumbnail { get; set; }

        [DataMember]
        public Product Product
        {
            get { return _product ?? (_product = new Product()); }
            protected set { _product = value; }
        }

        [DataMember]
        public Reviewer Reviewer
        {
            get { return _reviewer ?? (_reviewer = new Reviewer()); }
            protected set { _reviewer = value; }
        }

        [DataMember]
        public virtual ICollection<ReviewImage> ReviewImages
        {
            get { return _reviewImages ?? (_reviewImages = new HashSet<ReviewImage>()); }
            protected set { _reviewImages = value; }
        }
    }
}
