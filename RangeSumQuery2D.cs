public  class NumMatrix {
    int[][] prefixSum;
    public NumMatrix(int[][] matrix) 
    {
        prefixSum = new int[matrix.Length][];
        for (int i = 0; i < matrix.Length; i++) 
        {
            prefixSum[i] = new int[matrix[0].Length];
        }
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (i == 0 && j == 0)
                {
                    prefixSum[i][j] = matrix[i][j];
                }
                else if (i == 0)
                {
                    prefixSum[i][j] = prefixSum[i][j-1] + matrix[i][j];
                }
                else if (j == 0)
                {
                    prefixSum[i][j] = prefixSum[i-1][j] + matrix[i][j];
                }
                else
                {
                    prefixSum[i][j] = prefixSum[i-1][j] + prefixSum[i][j-1] - prefixSum[i-1][j-1] + matrix[i][j];
                }
            }
        }
    }
    
public int SumRegion(int row1, int col1, int row2, int col2) 
{
    // Check for null/empty matrix
    if (prefixSum == null || prefixSum.Length == 0 || prefixSum[0].Length == 0)
    {
        return 0;
    }

    // For 1x1 matrix, just return the value if the query matches
    if (prefixSum.Length == 1 && prefixSum[0].Length == 1)
    {
        if (row1 == 0 && col1 == 0 && row2 == 0 && col2 == 0)
            return prefixSum[0][0];
        return 0;
    }

    // Handle different edge cases
    if (row1 == 0 && col1 == 0)
    {
        return prefixSum[row2][col2];
    }
    else if (row1 == 0)
    {
        return prefixSum[row2][col2] - prefixSum[row2][col1 - 1];
    }
    else if (col1 == 0)
    {
        return prefixSum[row2][col2] - prefixSum[row1 - 1][col2];
    }
    else
    {
        return prefixSum[row2][col2] - prefixSum[row1 - 1][col2] - prefixSum[row2][col1 - 1] + prefixSum[row1 - 1][col1 - 1];
    }
}
}
