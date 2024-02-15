int a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[a];
int b=-999999;
for(int i=0;i<a;i++){
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
    for(int i=0;i<a;i++){
    if(arr[i]>b)b=arr[i];
    }
    for(int i=0;i<a;i++){
    if(b==arr[i])Console.Write(i);
    }
