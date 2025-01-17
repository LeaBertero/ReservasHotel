﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReservasHotel.DB.Data.Entidades 
{
    /* esta clase/tabla representa los dias y las habitaciones que puede tener una reseva
     puede haber varios registros que pertenecen a una misma reserva ya sea porque abarca varios dias 
    ej res 1 tiene el dia 23;24;25 o tambien porque una reserva puede incluir dos habitaciones o mas */
    
    [Index(nameof(HabitacionId),nameof(Fecha), Name = "diaIdHab_Uq", IsUnique = true)]
    //la clave unica valida que una habitacion no puede reservarse si ya esta reservada en determinada fecha o viceversa
    public class Reservacion
    {
        
        [Required]
        public int HabitacionId { get; set; }
        [Required]
        
        public int ReservaId { get; set; }

        [Required]
        [DataType(DataType.Date)]  
        public DateTime Fecha { get; set; }
        
        public int? Cant_Huespedes { get; set; }


        
    }
}
