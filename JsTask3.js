

function multiple(nums) {
    myIntegers = [];
    for (let i = 1; myIntegers.length <= nums; i++) {

        if (i % 2 === 0 && i % 3 === 0 && i % 5 === 0) { myIntegers[i] = "yu-gi-oh"; }
        else if (i % 2 === 0 && i % 3 === 0) { myIntegers[i] = "yu-gi"; }
        else if (i % 2 === 0 && i % 5 === 0) { myIntegers[i] = "yu-oh"; }
        else if (i % 3 === 0 && i % 5 === 0) { myIntegers[i] = "gi-oh"; }
        else if (i % 2 === 0) { myIntegers[i] = "yu"; }
        else if (i % 3 === 0) { myIntegers[i] = "gi"; }
        else if (i % 5 === 0) { myIntegers[i] = "oh"; }
        else { myIntegers.push(i); }

    }
    console.log(myIntegers)

}
multiple(100)

