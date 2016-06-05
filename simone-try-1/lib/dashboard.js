function space (n) {
  let arr = []
  for (let i = 0; i < n; i++) arr.push(' ')
  return arr.join('')
}

exports.print = robot => robot.printStatus((i, ...s) => console.log(space(i), ...s))
exports.rechargeCost = robot => robot.rechargeCost
