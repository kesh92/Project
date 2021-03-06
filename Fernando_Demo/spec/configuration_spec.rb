require 'spec_helper'

describe SwaggerClient::Configuration do
  let(:config) { SwaggerClient::Configuration.default }

  before(:each) do
    SwaggerClient.configure do |c|
      c.host = 'petstore.swagger.io'
      c.base_path = 'v2'
    end
  end

  describe '#base_url' do
    it 'should have the default value' do
      expect(config.base_url).to eq('http://petstore.swagger.io/v2')
    end

    it 'should remove trailing slashes' do
      [nil, '', '/', '//'].each do |base_path|
        config.base_path = base_path
        expect(config.base_url).to eq('http://petstore.swagger.io')
      end
    end
  end
end
