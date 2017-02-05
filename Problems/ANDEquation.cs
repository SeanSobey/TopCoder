public class ANDEquation
{
    public int restoreY(int[] A)
    {
        for (var i = 0; i < A.Length; i++)
        {
            var expectedResultant = A[i];
            var actualResultant = A[(i == A.Length - 1) ? 0 : (i + 1)];
            for (var j = 0; j < A.Length; j++)
            	if (i != j)
                    actualResultant = actualResultant & A[j];
            if (actualResultant == expectedResultant)
                return actualResultant;
        }
        return -1;
    }
}