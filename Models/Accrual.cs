using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificationTask.Models
{
    internal class Accrual
    {
        private ColdWaterSupply coldWaterSupply;
        private HotWaterSupply hotWaterSupply;
        private ElectricalEnergy electricalEnergy;

        public ColdWaterSupply GetColdWaterSupply()
        {
            return coldWaterSupply;
        }

        public void SetColdWaterSupply(ColdWaterSupply value)
        {
            coldWaterSupply = value;
        }

        public HotWaterSupply GetHotWaterSupply()
        {
            return hotWaterSupply;
        }

        public void SetHotWaterSupply(HotWaterSupply value)
        {
            hotWaterSupply = value;
        }

        public ElectricalEnergy GetElectricalEnergy()
        {
            return electricalEnergy;
        }

        public void SetElectricalEnergy(ElectricalEnergy value)
        {
            electricalEnergy = value;
        }
    }
}
