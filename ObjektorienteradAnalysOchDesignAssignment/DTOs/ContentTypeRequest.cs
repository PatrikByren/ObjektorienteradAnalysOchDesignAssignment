﻿using Microsoft.EntityFrameworkCore;
using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Interfaces.IContentType;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ObjektorienteradAnalysOchDesignAssignment.DTOs
{
    
    public class ContentTypeRequest : IContentTypeRequest
    {
        [Required]
        public string Name { get; set; } = null!;

        public static implicit operator ContentTypeEntity(ContentTypeRequest contentType)
        {
            var entity = ContentTypeFactory.CreateContentTypeEntity();
            entity.Name = contentType.Name;
            return entity;
        }
    }
}
