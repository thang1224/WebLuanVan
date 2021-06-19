﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebLuanVan.Data.ViewModels.ModelBinding
{
    public class ThesisViewModel
    {

        public string Id { get; set; }
        public string ThesisName { get; set; }

        public string StudentId { get; set; }

        public int Year { get; set; }

        public int Phase { get; set; }

        public int AcademicYear { get; set; }

        public string GuideLectureId { get; set; }
        public List<string> DebateLectureId { get; set; }

        public string FacultyId { get; set; }

        public string Content { get; set; }

        public string ThesisId { get; set; }
        public string Language { get; set; }
        public DateTime? ProtectedAt { get; set; }
        public DateTime? MakedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public int Score { get; set; }
        public bool IsProtected { get; set; }
    }
}