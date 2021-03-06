﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SupErp.BLL.ComptabilityBLL;
using SupErp.BLL.ComptabilityBLL.BllObject;
using SupErp.Entities;

namespace SupErp.WCF.ComptabilityWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IComptability" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IComptabilityService
    {
        [OperationContract]
        IEnumerable<ClassOfAccount> GetPlanComptable ();

        [OperationContract]
        COMPTA_ExchangeRate GetExhangeRate ();

        [OperationContract]
        IEnumerable<Entries> GetEntries ( string type, bool? paye, bool? impaye, DateTime? Debut, DateTime? Fin );

        [OperationContract]
        IEnumerable<BilanComptable> GetBilanComptable ( string Mode, DateTime? Debut, DateTime? Fin );
    }
}
