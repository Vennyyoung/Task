JsTask2;
let data = [
  { principal: 2500, time: 1.8 },
  { principal: 1000, time: 5 },
  { principal: 3000, time: 1 },
  { principal: 2000, time: 3 },
];

function interestCalculator(data) {
  
  let interestData = [];
  let rate;

for (let i = 0; i < data.length; i++) {
    
    if (data[i].principal >= 2500 && data[i].time > 1 && data[i].time < 3) {
      rate = 3;
    } else if (data[i].principal >= 2500 && data[i].time >= 3) {
      rate = 4;
    } else if (data[i].principal < 2500 || data[i].time <= 1) {
      rate = 2;
    } else {
      rate = 1;
    }
    let interest = (data[i].principal * data[i].time * rate)/100;
    //The code below helps to insert data[i],interest and rate into my empty array-interestData[]
    data[i].interest = interest;
    data[i].rate = rate;
    interestData.push(data[i]);
  }
  console.log(interestData);
  return interestData;
}

interestCalculator(data);
