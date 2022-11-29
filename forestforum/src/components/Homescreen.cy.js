import Homescreen from './Homescreen.vue'

describe('<Homescreen />', () => {
  it('renders', () => {
    // see: https://test-utils.vuejs.org/guide/
    cy.mount(Homescreen)
  })
})