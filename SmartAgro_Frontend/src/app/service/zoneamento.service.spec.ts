import { TestBed } from '@angular/core/testing';

import { ZoneamentoService } from './zoneamento.service';

describe('ZoneamentoService', () => {
  let service: ZoneamentoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ZoneamentoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
