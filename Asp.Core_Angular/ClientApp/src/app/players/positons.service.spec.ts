import { TestBed } from '@angular/core/testing';

import { PositonsService } from './positons.service';

describe('PositonsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PositonsService = TestBed.get(PositonsService);
    expect(service).toBeTruthy();
  });
});
