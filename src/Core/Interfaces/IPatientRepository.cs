using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinAgendaDemo.src.Application.DTOs.Patient;

namespace ClinAgendaDemo.src.Core.Interfaces
{
    public class IPatientRepository
    {
        Task<(int total, IEnumerable<PatientListDTO> patient)> GetPatientsAsync(string? name, string? documentNumber, int? statusId, int itemsPerPage, int page);
        Task<int> InsertPatientAsync(PatientInsertDTO patient);
        Task<PatientDTO?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(PatientDTO patient);
        Task<int> DeleteByPatientIdAsync(int patientId);
    }
}