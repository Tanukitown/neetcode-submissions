public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int top = 0;
        int bot = rows - 1;
        int row;

        while (top <= bot)
        {
            row = (top + bot) / 2;
            if (target > matrix[row][cols - 1])
            {
                top = row + 1;
            }
            else if (target < matrix[row][0]) {
                bot = row - 1;                
            }
            else
            {
                break;
            }
        }

        if (!(top <= bot))
        {
            return false;
        }

        row = (top + bot) / 2;
        int left = 0;
        int right = cols - 1;
        int mid;

        while (left <= right)
        {
            mid = (left + right) / 2;
            if (target > matrix[row][mid])
            {
                left = mid + 1;
            }
            else if (target < matrix[row][mid])
            {
                right = mid - 1;
            }
            else
            {
                return true;
            }
        }


        // for (int i = 0; i < matrix.Length; i++)
        // {
        //     if (matrix[i][0] <= target && matrix[i][matrix[i].Length - 1] >= target)
        //     {
        //         int left = 0;
        //         int right = matrix[i].Length - 1;
        //         int mid;

        //         while (left <= right)
        //         {
        //             mid = (left + right) / 2;
        //             if (target > matrix[i][mid])
        //             {
        //                 left = mid + 1;
        //             } else if (target < matrix[i][mid])
        //             {
        //                 right = mid - 1;
        //             } else if (target == matrix[i][mid])
        //             {
        //                 return true;
        //             } else
        //             {
        //                 return false;
        //             }
        //         }
        //     }
        // }

        // while (left <= right)
        // {
        //     if (matrix[left][0] <= target)
        //     {
        //         for (int i = 0; i < matrix[left].Length; i++)
        //         {
        //             if (matrix[left][i] == target)
        //             {
        //                 return true;
        //             }
        //         }
        //     }
        //     if (matrix[right][0] <= target)
        //     {
        //         for (int i = 0; i < matrix[right].Length; i++)
        //         {
        //             if (matrix[right][i] == target)
        //             {
        //                 return true;
        //             }
        //         }
        //     }
        //     left += 1;
        //     right -= 1;
        // }
        return false;
    }
}
