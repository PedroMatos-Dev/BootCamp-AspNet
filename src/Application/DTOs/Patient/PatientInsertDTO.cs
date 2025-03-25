using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinAgenda.src.Application.DTOs.Status;

namespace ClinAgendaDemo.src.Application.DTOs.Patient
{
    public class PatientInsertDTO
    {
         public class Patient
    {

        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
        public required string DocumentNumber { get; set; }
        public required int StatusId { get; set; }
        public required string BirthDateday { get; set; }
    }
    }
}