var RightFoot = require('../lib/components/RightFoot')

describe('right foot', function () {
  let foot

  beforeEach(() => {
    foot = new RightFoot({maxCharge: 1})
  })

  it('be off by default', () => {
    foot.status.should.equal('off')
  })

  it('should be able to turn on', () => {
    foot.switchOn()
    foot.status.should.equal('on')
  })

  it('should be able to turn on and off', () => {
    foot.switchOn()
    foot.switchOff()
    foot.status.should.equal('off')
  })

  it('should throw when instantiated without maxCharge', () => {
    (() => new RightFoot({})).should.throw('argument maxCharge is mandatory')
  })

  it('should get maxCharge', () => {
    foot.maxCharge.should.equal(1)
  })
})
