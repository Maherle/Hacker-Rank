class TwoDArray {
    public static int hourglassSum(int[][] arr) {
        int sum = int.MinValue;
        int firstR, middleR, lastR;


        for (int i=0 ; i<4 ; i++){
            for (int j=0; j<4; j++){
                firstR = arr[i][j] + arr[i][j+1] + arr[i][j+2];
                middleR = arr[i+1][j+1];
                lastR = arr[i+2][j]+arr[i+2][j+1]+arr[i+2][j+2];
                if (firstR + middleR + lastR > sum) sum = firstR + middleR + lastR;
            }
        }

        return sum;
    }    
}