var LeftArm = require('../lib/components/LeftArm')

describe('left arm', function () {
  let arm

  beforeEach(() => {
    arm = new LeftArm({maxCharge: 1})
  })

  it('be off by default', () => {
    arm.status.should.equal('off')
  })

  it('should be able to turn on', () => {
    arm.switchOn()
    arm.status.should.equal('on')
  })

  it('should be able to turn on and off', () => {
    arm.switchOn()
    arm.switchOff()
    arm.status.should.equal('off')
  })

  it('should throw when instantiated without maxCharge', () => {
    (() => new LeftArm({})).should.throw('argument maxCharge is mandatory')
  })

  it('should get maxCharge', () => {
    arm.maxCharge.should.equal(1)
  })
})
