
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Data.EntityFramework.DAL
{

using System;
    using System.Collections.Generic;
    
public partial class Kategorija
{

    public Kategorija()
    {

        this.PodKategorija = new HashSet<PodKategorija>();

    }


    public int id { get; set; }

    public string Naslov { get; set; }

    public string Opis { get; set; }

    public Nullable<System.DateTime> DatumKreiranja { get; set; }



    public virtual ICollection<PodKategorija> PodKategorija { get; set; }

}

}
