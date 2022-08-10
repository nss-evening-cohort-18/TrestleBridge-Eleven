using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;
using trestleBridge.Models.Facilities;

namespace trestleBridge
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;

                default:
                    break;
            }
        }

        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();

        public void PlowedFieldResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Sunflower":
                    PlowedFields[index].AddResource((IFlower)resource);
                    break;
                case "Sesame":
                    PlowedFields[index].AddResource((IFlower)resource);
                    break;
                default:
                    break;
            }
        }

        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void NaturalFieldResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Sunflower":
                    NaturalFields[index].AddResource((IFlower)resource);
                    break;
                case "Wildflower":
                    NaturalFields[index].AddResource((IFlower)resource);
                    break;
                default:
                    break;
            }
        }

        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void CHFieldResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Chicken":
                    ChickenHouses[index].AddResource((IGrazing)resource);
                    break;
                
                default:
                    break;
            }
        }

        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void DHFieldResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Duck":
                    DuckHouses[index].AddResource((IGrazing)resource);
                    break;
                
                default:
                    break;
            }
        }

        public void AddChickenHouse(ChickenHouse ch)
        {

            ChickenHouses.Add(ch);
        }

        public void AddDuckHouse(DuckHouse dh)
        {

            DuckHouses.Add(dh);
        }

        public void AddNaturalField(NaturalField naturalField)
        {

            NaturalFields.Add(naturalField);
        }

        public void AddPlowedField(PlowedField plowedField)
        {
            
            PlowedFields.Add(plowedField);
        }

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
        }
                

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            NaturalFields.ForEach(nf => report.Append(nf));
            PlowedFields.ForEach(pf => report.Append(pf));
            ChickenHouses.ForEach(ch => report.Append(ch));
            DuckHouses.ForEach(dh => report.Append(dh));


            return report.ToString();
        }




    }
}
