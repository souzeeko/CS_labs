using cs_labs.CS_lab_3
namespace CS_individual_3
{
    public class Individual_3: Vector
    {
        public double  GetByIndex(int i)
        {
            return this.array[i];
        }

        public void SetByindex(int i, double value)
        {
            this.array[i] = value;
        }

        public void FillRandom(int a, int b)
        {
            Random rnd = new Random();
            for (int i = 0; i < this.array.Length; i++)
            {
                this.data[i] = rnd.Next(a, b);
            }
        }

        public int Find(double value)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool IsSorted()
        {
            for (int i = 1; i < this.array.Length; i++)
            {
                if (this.array[i] < this.array[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}