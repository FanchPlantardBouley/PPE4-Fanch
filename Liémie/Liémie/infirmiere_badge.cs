//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Liémie
{
    using System;
    using System.Collections.Generic;
    
    public partial class infirmiere_badge
    {
        public int id_infirmiere { get; set; }
        public int id_badge { get; set; }
        public System.DateTime date_deb { get; set; }
        public Nullable<System.DateTime> date_fin { get; set; }
    
        public virtual badge badge { get; set; }
        public virtual infirmiere infirmiere { get; set; }
    }
}
