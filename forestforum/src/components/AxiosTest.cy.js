import AxiosTest from './AxiosTest.vue'

describe('<AxiosTest />', () => {
  it('renders', () => {
    // see: https://test-utils.vuejs.org/guide/
    cy.mount(AxiosTest)
  })
})