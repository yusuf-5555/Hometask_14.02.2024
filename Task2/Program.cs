int a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[a];
int cnt=1;
for(int i=0;i<a;i++){
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<a;i++){
    if(i==a-1){
        Console.Write(arr[i]);
        cnt=cnt*arr[i];
        break;
    }
    Console.Write($"{arr[i]}*");
    cnt=cnt*arr[i];
}
Console.Write($"={cnt}");