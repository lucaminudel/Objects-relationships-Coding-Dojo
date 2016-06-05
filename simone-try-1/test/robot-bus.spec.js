let LeftArm = require('../lib/components/LeftArm')
let RightFoot = require('../lib/components/RightFoot')
let RightThigh = require('../lib/components/RightThigh')
let RobotBus = require('../lib/components/RobotBus')

describe('robot bus', () => {
  let robotBus

  beforeEach(() => {
    robotBus = new RobotBus({
      leftArm: new LeftArm({maxCharge: 1}),
      rightFoot: new RightFoot({maxCharge: 1}),
      rightThigh: new RightThigh({maxCharge: 1})
    })
  })

  it('should be off by default', () => {
    robotBus.status.should.equal('off')
  })

  it('should be able to switch on', () => {
    robotBus.switchOn()
    robotBus.status.should.equal('on')
  })

  it('should be able to switch on and off again', () => {
    robotBus.switchOn()
    robotBus.switchOff()
    robotBus.status.should.equal('off')
  })

  it('should throw if left arm is not provided', () => {
    (() => new RobotBus()).should.throw('argument leftArm is mandatory')
  })

  it('should throw if rightFoot is not provided', () => {
    (() => new RobotBus({
      leftArm: new LeftArm({maxCharge: 1})
    })).should.throw('argument rightFoot is mandatory')
  })
})
