let RobotBus = require('../lib/components/RobotBus')
let RightFoot = require('../lib/components/RightFoot')
let LeftArm = require('../lib/components/LeftArm')
let RightThigh = require('../lib/components/RightThigh')

let dashboard = require('../lib/dashboard')

describe('dashboard', () => {
  let robot

  beforeEach(() => {
    robot = new RobotBus({
      leftArm: new LeftArm({maxCharge: 1}),
      rightFoot: new RightFoot({maxCharge: 1}),
      rightThigh: new RightThigh({ maxCharge: 2})
    })
  })

  it('should display status of robot and its parts', () => {
    dashboard.print(robot)
  })

  it('should compute recharge cost', () => {
    dashboard.rechargeCost(robot).should.equal(.8)
  })
})
