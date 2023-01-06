namespace WareHouse;

public class Part{
        public string PartName { get; set; }

        public int PartId { get; set; }

        public Part (string partname , int partid){
            this.PartName = partname;
            this.PartId = partid;
        }
        public override string ToString()
        {
            return "Name:" + PartName + "   Id: " + PartId;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartId.Equals(other.PartId));
        }
        
        public override int GetHashCode()
        {
            return PartId;
        }
}