import { TestBed } from '@angular/core/testing';

import { AdubacaoService } from './adubacao.service';

describe('AdubacaoService', () => {
  let service: AdubacaoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AdubacaoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
