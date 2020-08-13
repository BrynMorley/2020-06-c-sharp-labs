// console.log('hello world from Node')
// for(let i=0;i<=10;i++)
// {
//     console.log(i)
// }



doThis = () =>{
    console.log('2 seconds have passed')
}

var counter =0;
alsoDoThis = () =>{
    console.log(new Date());
    counter++;
    if(counter>=10){
        clearInterval(runningTimer)
    }
}

//set timeout = delay 2 seconds then print something
setTimeout(doThis,2000);

//set interval = print every 2 seconds unti stop application
var runningTimer = setInterval(alsoDoThis,1000);

//arrays
console.log("\n\n array")
const myArray =[10,20,30];
console.log(myArray);

for (let i =0;i<myArray.length;i++){
    console.log(myArray[i])
}

//push and pop, shift and unshift
myArray.push(400);
myArray.push(500);
console.log(myArray);
myArray.pop();
console.log(myArray);
myArray.unshift(5);
console.log(myArray);